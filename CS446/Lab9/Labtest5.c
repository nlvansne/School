#include <sys/mman.h> /*For mmap() function*/
#include <sys/stat.h>
#include <string.h> /*For memcpy function*/
#include <fcntl.h> /*For file descriptors*/
#include <stdlib.h> /*For file descriptors*/
#include <stdio.h> /*For writing to Console*/

#define MEMORY_SIZE 1
#define CHAR_SIZE 1


signed char* mmapfptr;
signed char* mmapfptr2;
struct stat sb1;
struct stat sb2;


int main(int argc, char* argv[]) {

	if (argc < 3) {
		printf("Include file name in args!\n");
		return(1);
	}

	int mmapfile_fd1 = open(argv[1], O_RDONLY);
	int mmapfile_fd2 = open(argv[2], O_RDONLY);

	fstat(mmapfile_fd1, &sb1);
	fstat(mmapfile_fd2, &sb2);


	signed char buffer[sb1.st_size + sb2.st_size];

	mmapfptr = mmap(0, sb1.st_size, PROT_READ, MAP_PRIVATE,
		mmapfile_fd1, 0);

	int i = 0;
	int temp = 0;
	for (i = 0; i < sb1.st_size; i++) {
		memcpy(buffer + i, mmapfptr + temp, CHAR_SIZE);
		temp += 3;
		if (temp >= sb1.st_size) {
			memcpy(buffer + i + 1, mmapfptr + temp - 2, CHAR_SIZE);
			i = sb1.st_size;
		}
	}
	i = i - temp;

	munmap(mmapfptr, sb1.st_size);


	mmapfptr2 = mmap(0, sb2.st_size, PROT_READ, MAP_PRIVATE,
		mmapfile_fd2, 0);

	temp = 0;
	buffer[10] = ' ';
	for (i = i + 10; i < sb1.st_size + sb2.st_size; i++) {
		memcpy(buffer + i, mmapfptr2 + temp, CHAR_SIZE);

		temp += 2;
		if (temp > sb1.st_size + sb2.st_size) {
			i = sb1.st_size + sb2.st_size;
		}
	}

	munmap(mmapfptr2, sb2.st_size);


	printf("%s\n", buffer);

	return 0;
}
