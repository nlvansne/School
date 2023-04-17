#include <stdio.h>
#include <stdlib.h>

#define SIZE 8


void selectionSort(int arr[], int n);
void swap(int* xp, int* yp);
int SCAN(int start, char direction[], int tempArr[]);
int SSTF(int start, int tempArr[]);
int FCFS(int start, int tempArr[]);

int arr[SIZE] = {98, 183, 37, 122, 14, 124, 65, 67};


int main(int argc, char* argv[]) {
	if (argc != 3) {
		printf("run as ./assignment4 start direction");
		return 1;
	}

	FCFS(atoi(argv[1]), &arr);
	SSTF(atoi(argv[1]), &arr);
	SCAN(atoi(argv[1]), argv[2], arr);
}

int FCFS(int start, int tempArr[]) {
	printf("FCFS DISK SCHEDULING ALGORITHM\n\n");

	int totalDisk = 0;

	int i = 0;
	for (i = 0; i < SIZE; i++) {
		totalDisk = totalDisk + abs(start - tempArr[i]);
		start = tempArr[i];

		printf("FCFS - servicing request: %d\n", tempArr[i]);
	}

	printf("FCFS - Total head movements = %d\n\n\n", totalDisk);
	
	
}

int SSTF(int start, int tempArr[]) {
	printf("SSTF DISK SCHEDULING ALGORITHM\n\n");

	int temp[sizeof(tempArr)];

	int j = 0;
	for (j = 0; j < sizeof(tempArr); j++) {
		temp[j] = tempArr[j];
	}

	int totalDisk = 0;

	int i = 0;
	for (i = 0; i < SIZE; i++) {
		int j = 0;
		int closest = 0;
		int distance = 200;
		for (j = 0; j < SIZE; j++) {
			if (temp[j] != -1) {
				if (abs(start - temp[j]) < distance) {
					distance = abs(start - temp[j]);
					closest = j;
				}
			}
		}

		printf("SSTF - serving request: %d\n", temp[closest]);

		totalDisk += abs(start - temp[closest]);
		start = temp[closest];
		temp[closest] = -1;
	}

	printf("SSTF - Total head movements = %d\n\n\n", totalDisk);
}


int SCAN(int start, char direction[], int tempArr[]) {
	printf("SCAN DISK SCHEDULING ALGORITHM\n\n");

	//Sort array into ascending order
	selectionSort(tempArr, sizeof(tempArr));

	int startingPosition = 0;
	int totalDisk = 0;


	int j = 0;
	for (j = 0; j < sizeof(tempArr); j++) {
		if (tempArr[j] > start) {
			if (j > 0) {
				startingPosition = j - 1;
			}
			break;
		}
	}

	int run = 2;
	while (run > 0) {
		if (strcmp(direction, "LEFT") == 0) {
			int tempPos = startingPosition;
			
			while (tempPos >= 0) {
				totalDisk += abs(start - tempArr[tempPos]);
				printf("SCAN - servicing request: % d\n", tempArr[tempPos]);
				start = tempArr[tempPos];
				
				if (tempPos == 0 && run == 2) {
					totalDisk += abs(start - 0);
				}
				tempPos--;
			}
			direction = "RIGHT";
			start = 0;
		}else if (strcmp(direction, "RIGHT") == 0) {
			int tempPos = startingPosition + 1;

			while (tempPos < sizeof(tempArr)) {
				totalDisk += abs(start - tempArr[tempPos]);
				printf("SCAN - servicing request: % d\n", tempArr[tempPos]);
				start = tempArr[tempPos];
				tempPos++;

				if (tempPos == sizeof(tempArr) && run == 2) {
					totalDisk += abs(start - 199);
				}
			}
			direction = "LEFT";
			start = 199;
		}

		run--;
	}

	printf("SSTF - Total head movements = %d\n", totalDisk);
}



void swap(int* xp, int* yp)
{
	int temp = *xp;
	*xp = *yp;
	*yp = temp;
}

// Function to perform Selection Sort
void selectionSort(int arr[], int n)
{
	int i, j, min_idx;

	// One by one move boundary of unsorted subarray
	for (i = 0; i < n - 1; i++) {

		// Find the minimum element in unsorted array
		min_idx = i;
		for (j = i + 1; j < n; j++)
			if (arr[j] < arr[min_idx])
				min_idx = j;

		// Swap the found minimum element
		// with the first element
		swap(&arr[min_idx], &arr[i]);
	}
}





