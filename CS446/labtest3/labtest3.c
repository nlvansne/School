
#include<stdio.h>
#include<string.h>
#include<pthread.h>
#include<stdlib.h>
#include<unistd.h>

pthread_t tid[2];
static int balance;
pthread_mutex_t lock;

void* withdraw(void* arg)
{
    int withdrawled = 0;
    int* amount = (int*)arg;

    while (withdrawled != 1) {
        pthread_mutex_lock(&lock);

        printf("Executing withdrawl function\n");
        if (balance > 0) {
            balance = balance - amount[0];
            printf("Amount after withdrawl = %d\n", balance);
            withdrawled = 1;
        }

        pthread_mutex_unlock(&lock);
    }

    pthread_exit(0);
}


void* deposit(void* arg)
{
    int deposited = 0;
    int* amount = (int*)arg;

    while (deposited != 1) {
        pthread_mutex_lock(&lock);

        printf("Executing deposit function\n");

        if (balance < 400) {
            balance = balance + amount[0];
            printf("Amount after deposit = %d\n", balance);
            deposited = 1;
        }

        pthread_mutex_unlock(&lock);
    }
    pthread_exit(0);
}

int main(int argc, char* argv[])
{
    balance = 0;
    int err;

    if (argc != 3) {
        fprintf(stderr, "usage: a.out <deposit> <withdraw>\n");
        return 1;
    }

    if(atoi(argv[1]) < 0 || atoi(argv[2]) < 0){
        fprintf(stderr, "Enter a positive integers!\n");
        return 1;
    }

    int withdrawVal[1] = { 0 };
    int depositVal[1] = { 0 };
    depositVal[0] = atoi(argv[1]);
    withdrawVal[0] = atoi(argv[2]);

    if (pthread_mutex_init(&lock, NULL) != 0)
    {
        printf("\n mutex init failed\n");
        return 1;
    }

    for(int i = 0; i < 7; i++){
        err = pthread_create(&(tid[i]), NULL, deposit, depositVal);
        if (err != 0)
            printf("\ncan't create thread :[%s]\n", strerror(err));
    }

   for(int i = 7; i < 10; i++){
        err = pthread_create(&(tid[i]), NULL, withdraw, withdrawVal);
        if (err != 0)
            printf("\ncan't create thread :[%s]", strerror(err));
    }

    for (int i = 0; i < 10; i++) {
        pthread_join(tid[i], NULL);
   }

    pthread_mutex_destroy(&lock);

    printf("Final amount = %d\n", balance);

    return 0;
}








