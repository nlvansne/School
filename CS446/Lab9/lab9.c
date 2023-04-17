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
