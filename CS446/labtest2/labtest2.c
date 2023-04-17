/**
 * A pthread program illustrating how to
 * create a simple thread and some of the pthread API
 * This program implements the summation function where
 * the summation operation is run as a separate thread.
 *
 * Figure 4.11 in the textbook
 *
 * Most Unix/Linux/OS X users
 * To compile, enter:
 * gcc thrd.c -lpthread
 */

#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>

int maxNum[2] = { 0 }; /* this data is shared by the thread(s) */

void* runner(void *param); /* the thread */

int main(int argc, char* argv[])
{
	int num[10] = { 1, 2, 5, 17, 8, 6, 4, 2, 9, 0 };

	pthread_t tid; /* the thread identifier */
	pthread_attr_t attr; /* set of attributes for the thread */
	int i;
	int a[6] = { 0 };
	int b[6] = { 0 };

	a[0] = 0;
	b[0] = 1;

	for (i = 0; i < 5; i++) {
		a[i + 1] = num[i];
	}

	for (i = 5; i < 10; i++) {
		b[i - 4] = num[i];
	}


	/* get the default attributes */
	pthread_attr_init(&attr);

	/* create the thread */
	pthread_create(&tid, &attr, runner, a);

	/* now wait for the thread to exit */
	pthread_join(tid, NULL);

	/* get the default attributes */
	pthread_attr_init(&attr);

	/* create the thread */
	pthread_create(&tid, &attr, runner, b);

	/* now wait for the thread to exit */
	pthread_join(tid, NULL);

	int max = 0;

	if (maxNum[0] > maxNum[1]) {
		max = maxNum[0];
	}
	else {
		max = maxNum[1];
	}

	printf("Max number = %d\n", max);
}

/**
 * The thread will begin control in this function
 */
void* runner(void *param)
{
	//int i, upper = atoi(param);
	int* a = (int*)param;
	int i;

	for (i = 0; i < 5; i++) {
		if (maxNum[a[0]] < a[i]) {
			maxNum[a[0]] = a[i];
		}
	}

	pthread_exit(0);
}
