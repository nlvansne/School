#include <stdio.h>
#include <sys/mman.h> /*For mmap() function*/
#include <string.h> /*For memcpy function*/
#include <fcntl.h> /*For file descriptors*/
#include <stdlib.h> /*For file descriptors*/ 
#include <sys/stat.h>

#define PAGE_NUMBER_MASK 255		//2^8 -1
#define OFFSET_MASK 255			// 2^8 -1
#define PAGES 256
#define OFFSET_BITS  8			//Number of bits to represent an offset = number of bits to 							represent page size.
#define PAGE_SIZE 256	





int main(int argc, char* argv[])
{   
	unsigned int page_number, frame_number;
	int offset;
	unsigned int virtual_address, physical_address;
	char buff[10];

	int page_counter = 0;


	int page_table[PAGES] = -1;




	FILE* fptr = fopen(argv[1], "r");

	if (fptr == NULL) {
		printf("Error in opening file \n");
		return -1;
	}

	while (fgets(buff, 1000, fptr) != NULL) {
		virtual_address = atoi(buff);
		/*Mask the page number, this will enable you get your
		page number bits, then do a bit shift to the right by the
		number of offset bits. To get all the page number bits.
		The compiler automatically outputs the correct decimal
		representation of it.*/
		page_number = (virtual_address >> OFFSET_BITS) & PAGE_NUMBER_MASK;
		frame_number = page_table[page_number];
		offset = virtual_address & OFFSET_MASK;
		/*Move the bits in frame_number to left by the number of bits in
		the offset bit, then or it will the offset to get the physical address.*/
		physical_address = (frame_number << OFFSET_BITS) | offset;
		printf("Virtual addr is %d: Page# = %d & Offset = %d. Physical addr = %d. \n", virtual_address, page_number, offset, physical_address);
	}
	/*Close the file.*/
	fclose(fptr);

	return 0;
}










