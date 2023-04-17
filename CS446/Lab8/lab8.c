
#include <stdio.h>
#include <stdlib.h>
#include <string.h>


#define PAGE_NUMBER_MASK 255
#define OFFSET_MASK 255
#define PAGES 8
#define OFFSET_BITS 12
#define PAGE_SIZE 4096
#define ADD_COUNT 20  //Number of inputs




int main(int argc, char* argv[]) {

	FILE* adrFile;
	int buffSize = 10;
	char buff[buffSize];
	int i;
	
	int page_table[PAGES] = { 6, 4, 3, 7, 0, 1, 2, 5 };

	for (i = 0; i < PAGES; i++) {
		page_table[i] = -1;
	}

	adrFile = fopen(argv[1], "r");
	
	int freePage = 0;

	for (i = 0; i < ADD_COUNT; i++) {
		fgets(buff, buffSize, adrFile);

		int logical_adr = atoi(buff);

		int offset = logical_adr % PAGE_SIZE;
		int page_number = (logical_adr >> OFFSET_BITS) & PAGE_NUMBER_MASK; 
		
		int physical = page_table[page_number];
		
	


		if (physical == -1) {

			physical = freePage;
			freePage++;

			page_table[page_number] = physical;
		}

		int physical_addr = (physical << (OFFSET_BITS - 1)) | offset;


		printf("Virtual Addr is %d:, Page# = : %d & offset = %d. Physical addr = %d.\n", logical_adr, page_number, offset, physical_addr);
		
	}

	fclose(adrFile);
}













