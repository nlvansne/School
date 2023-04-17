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

int sum; /* this data is shared by the thread(s) */

void* runner(void *param); /* the thread */

int main(int argc, char* argv[])
{
	pthread_t tid; /* the thread identifier */
	pthread_attr_t attr; /* set of attributes for the thread */

	if (argc != 21) {
		//fprintf(stderr, "usage: a.out <integer value>\n");
		fprintf(stderr, "usage: a.out <integer value> * 20");
		/*exit(1);*/
		return -1;
	}

	int i;
	for (i = 1; i < 21; i++) {
		if (atoi(argv[i]) < 0) {
			fprintf(stderr, "Argument %d must be non-negative\n", atoi(argv[i]));
			return -1;
		}
	}

	int a[10] = { 0 };
	for (i = 1; i < 11; i++) {
		a[i - 1] = atoi(argv[i]);
	}

	int b[10] = { 0 };
	for (i = 11; i < 21; i++) {
		b[i - 10] = atoi(argv[i]);
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
	pthread_create(&tid, &attr, runner, a);

	/* now wait for the thread to exit */
	pthread_join(tid, NULL);

	printf("sum = %d\n", sum);
}

/**
 * The thread will begin control in this function
 */
void* runner(void *param)
{
	//int i, upper = atoi(param);
	int* a = (int*)param;
	int i;

	for (i = 0; i < 10; i++) {
		sum += a[i];
	}

	pthread_exit(0);
}
