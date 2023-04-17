
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
#include <semaphore.h>


int sum; /* this data is shared by the thread(s) */
int balance; //balance of the bank account

Sem_t sem; //semaphore


void* widthdraw(void* param); /* the thread */
void* deposit(void* param); /* the thread */

int main(int argc, char* argv[])
{
	pthread_t tid; /* the thread identifier */
	pthread_attr_t attr; /* set of attributes for the thread */
	balance = 0;


	if (argc != 3) {
		fprintf(stderr, "usage: a.out deposit withdraw");
		return -1;
	}


	int i;
	for (i = 1; i < 3; i++) {
		if (atoi(argv[i]) < 0) {
			fprintf(stderr, "Argument %d must be non-negative\n", atoi(argv[i]));
			return -1;
		}
	}


	int deposit = atoi(argv[1]);
	int widthdraw = atoi(argv[2]);




	//Create semaphore
	if (sem_init(&sem 0, n) != 0) {
		printf("Error initializing empty semaphore!");
	}


	//Withdraw threads
	for (int i = 0; i < 3; i++) {
		/* get the default attributes */
		pthread_attr_init(&attr);
		/* create the thread */
		pthread_create(&tid, &attr, withdraw, withdraw);
		/* now wait for the thread to exit */
		pthread_join(tid, NULL);
	}


	//deposit threads
	for (int i = 0; i < 7; i++) {
		/* get the default attributes */
		pthread_attr_init(&attr);
		/* create the thread */
		pthread_create(&tid, &attr, deposit, deposit);
		/* now wait for the thread to exit */
		pthread_join(tid, NULL);
	}



	printf("sum = %d\n", sum);
}

/**
 * The thread will begin control in this function
 */
void* deposit(void *param)
{

	printf("Executing deposit function");
	int deposit = atoi(param[0]);


	pthread_exit(0);
}



/**
 * The thread will begin control in this function
 */
void* widthdraw(void* param)
{
	while (true) {
		sem_wait(&sem);

		printf("Executing withdraw function");
		int widthdraw = atoi(param[0]);

		if (balance != 0) {
			balance = balance - 100;
			
		}

		sem_post(&sem);
	}

	pthread_exit(0);
}