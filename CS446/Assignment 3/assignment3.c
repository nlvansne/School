#include <stdio.h>
#include <sys/mman.h> /*For mmap() function*/
#include <string.h> /*For memcpy function*/
#include <fcntl.h> /*For file descriptors*/
#include <stdlib.h> /*For file descriptors*/ 


#define PAGE_NUMBER_MASK 255		//2^8 -1
#define OFFSET_MASK 255			// 2^8 -1
#define PAGES 256
#define OFFSET_BITS  8			//Number of bits to represent an offset = number of bits to represent page size.
#define PAGE_SIZE 256	
#define TLB_SIZE 16
#define BINARY_FILE_SIZE 65536
#define physical_Memory_Bytes 65536


FILE* adrFile;
int buffSize = 10;
int page_table[PAGES];
int page_counter = 0;
int page_Faults = 0;

int next_available_frame = 0;

signed char* mmapfptr;


int physical_Memory[physical_Memory_Bytes];


int tlbHits = 0;
struct TLBentry{
	int page;
	int frame;
} tlb[TLB_SIZE];
int tlb_position = 0;

FILE* output;


int initializeArray(int *arr, int size) {
	int i = 0;
	for (i = 0; i < size; i++) {
		arr[i] = -1;
	}
}


int main(int argc, char* argv[]) {

	if (argc != 3) {
		printf("./assignment3 file1 file2");
		return 1;
	}

	//Open up the BACKING_STORE.bin file
	int mmapfile_fd = open(argv[2], O_RDONLY);

	mmapfptr = mmap(0, BINARY_FILE_SIZE, PROT_READ, MAP_PRIVATE,
		mmapfile_fd, 0);



	initializeArray(page_table, PAGES);


	output = fopen("Output.txt", "w");


	adrFile = fopen(argv[1], "r");
	char buffer[buffSize];

	int i = 0;
	for (i = 0; i < 1000; i++) {
		fgets(buffer, buffSize, adrFile);

		int logical_adr = atoi(buffer);
		int offset = logical_adr & OFFSET_MASK;
		int page_number = (logical_adr >> OFFSET_BITS) & PAGE_NUMBER_MASK;

		int frame = searchTLB(page_number);
		
		if (frame == -1) {
			addTLB(page_number);
		}


		int physical = page_table[page_number];
		int physical_addr = (physical << OFFSET_BITS) | offset;

		fprintf(output, "Virtual Address: %d Physical address: %d Value: %d\n", logical_adr, physical_addr, physical_Memory[physical_addr]);

		printf("Virtual Address: %d Physical address: %d Value: %d\n", logical_adr, physical_addr, physical_Memory[physical_addr]);
	}

	fprintf(output, "Number of translated addresses = 1000\n");
	fprintf(output, "Page Faults = %d\n", page_Faults);
	fprintf(output, "TLB Hits = %d\n", tlbHits);


	printf("Number of translated addresses = 1000\n");
	printf("Page Faults = %d\n", page_Faults);
	printf("TLB Hits = %d\n", tlbHits);

	fclose(adrFile);
	fclose(output);
}


int backingStore(int page) {
	int frame = 0;
	int start_frame = 0;
	signed char mmapBuffer[PAGE_SIZE];

	memcpy(mmapBuffer, mmapfptr + page * PAGE_SIZE, PAGE_SIZE);

	frame = next_available_frame;
	next_available_frame++;

	start_frame = PAGE_SIZE * frame;

	int j = 0;
	for (j = 0; j < PAGE_SIZE; j++) {
		physical_Memory[start_frame] = mmapBuffer[j];
		start_frame++;
	}

	page_table[page] = frame;
	page_Faults++;

	return frame;
}



int searchTLB(int page) {
	int frame = -1;

	int i = 0;
	for (i = 0; i < TLB_SIZE; i++) {
		if (tlb[i].page == page) {
			frame = tlb[i].page;
			tlbHits++;
		}
	}

	return frame;
}



int addTLB(int page) {
	int frame = -1;

	if (page_table[page] == -1) {
		frame = backingStore(page);
	}
	else {
		frame = page_table[page];
	}

	tlb[tlb_position % TLB_SIZE].page = page;
	tlb[tlb_position % TLB_SIZE].frame = frame;
	tlb_position++;

	return frame;
}





