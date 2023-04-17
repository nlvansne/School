#include <sys/mman.h> /*For mmap() function*/
#include <sys/stat.h>
#include <string.h> /*For memcpy function*/
#include <fcntl.h> /*For file descriptors*/
#include <stdlib.h> /*For file descriptors*/
#include <stdio.h> /*For writing to Console*/

#define MEMORY_SIZE 1
#define CHAR_SIZE 1


signed char* mmapfptr;
struct stat sb;


int main(int argc, char* argv[]) {

	if (argc < 2) {
		printf("Include file name in args!\n");
		return(1);
	}

	int mmapfile_fd = open(argv[1], O_RDONLY);

	fstat(mmapfile_fd, &sb);


	signed char buffer[sb.st_size];

	mmapfptr = mmap(0, sb.st_size, PROT_READ, MAP_PRIVATE,
		mmapfile_fd, 0);

	int i = 0;
	int temp = 0;
	for (i = 0; i < sb.st_size; i++) {
		memcpy(buffer + i, mmapfptr + temp, CHAR_SIZE);
		if (i % 2 == 0) {
			temp += 3;
		}
		else {
			temp += 2;
		}

	}



	munmap(mmapfptr, sb.st_size);
	printf("%s\n", buffer);

	return 0;
}

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


#define PAGE_NUMBER_MASK 63
#define OFFSET_MASK 63
#define PAGES 8
#define OFFSET_BITS 8
#define PAGE_SIZE 256
#define ADD_COUNT 10  //Number of inputs




int main(int argc, char* argv[]) {

	FILE* adrFile;
	int buffSize = 10;
	char buff[buffSize];
	int i;

	int page_table[PAGES] = { 6, 4, 3, 7, 0, 1, 2, 5 };

	adrFile = fopen(argv[1], "r");


	for (i = 0; i < ADD_COUNT; i++) {
		fgets(buff, buffSize, adrFile);

		int logical_adr = atoi(buff);

		int offset = logical_adr % PAGE_SIZE;
		int page_number = (logical_adr >> OFFSET_BITS) & PAGE_NUMBER_MASK;

		int physical = page_table[page_number];


		int physical_addr = (physical << OFFSET_BITS) | offset;


		printf("Virtual Addr is %d:, Page# = : %d & offset = %d. Physical addr = %d.\n", logical_adr, page_number, offset, physical_addr);

	}

	fclose(adrFile);
}













