#include <stdio.h>
#include <sys/mman.h> /*For mmap() function*/
#include <string.h> /*For memcpy function*/
#include <fcntl.h> /*For file descriptors*/
#include <stdlib.h> /*For file descriptors*/ 


#define PAGE_NUMBER_MASK 255		//2^8 -1
#define OFFSET_MASK 255			// 2^8 -1
#define PAGES 256
#define OFFSET_BITS  8			//Number of bits to represent an offset = number of bits to 							represent page size.
#define PAGE_SIZE 256	
#define TLB_SIZE 16
#define BINARY_FILE_SIZE 65536


FILE* adrFile;
int buffSize = 10;
int page_table[PAGES];
int page_counter = 0;
int page_Faults = 0;


int tlbHits = 0;
signed char* mmapfptr;

int initializeArray(int *arr, int size) {
	int i = 0;
	for (i = 0; i < size; i++) {
		arr[i] = -1;
	}
}


int main(int argc, char* argv[]) {
	//Open up the BACKING_STORE.bin file
	int mmapfile_fd = open(argv[2], O_RDONLY);
	char mmapBuffer[PAGE_SIZE];

	mmapfptr = mmap(0, BINARY_FILE_SIZE, PROT_READ, MAP_PRIVATE,
		mmapfile_fd, 0);

	memcpy(mmapBuffer, mmapfptr, PAGE_SIZE);

	printf("%s\n", mmapBuffer);





	initializeArray(page_table, PAGES);

	adrFile = fopen(argv[1], "r");
	char buffer[buffSize];

	int i = 0;
	for (i = 0; i < 1000; i++) {
		fgets(buffer, buffSize, adrFile);

		int logical_adr = atoi(buffer);
		int offset = logical_adr & OFFSET_MASK;
		int page_number = (logical_adr >> OFFSET_BITS) & PAGE_NUMBER_MASK;


		if (page_table[page_number] == -1) {
			page_table[page_number] = page_counter;

			page_counter++;
			page_Faults++;
		}

		int physical = page_table[page_number];
		int physical_addr = (physical << OFFSET_BITS) | offset;


		//printf("Virtual Address: %d Physical address: %d\n", logical_adr, physical_addr);
	}

	printf("Number of translated addresses = 1000\n");
	printf("Page Faults = %d\n", page_Faults);
	printf("TLB Hits = %d\n", tlbHits);

	fclose(adrFile);
}


int backingStore(int page) {
	

}







