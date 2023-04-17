
#include <stdio.h>
#include <string.h>
#include <pthread.h>
#include <stdlib.h>
#include <unistd.h>
#include <stdlib.h>
#include <semaphore.h>
#include <time.h>

//Buffer Info
#define BUFFER_SIZE 10
//typedef int item;
int buffer[BUFFER_SIZE];
int in = 0;
int out = 0;

//Array for threads
pthread_t tid[2];

//Create Mutex
pthread_mutex_t lock;

//create semaphore
sem_t empty;
sem_t full;


void* producer(void* arg) 
{
    int next_produced;
    time_t t;
    srand((unsigned)time(&t));

    while (1) {
        /* prduce an item in next_prduced*/

        while (((in + 1) % BUFFER_SIZE) == out) {
            //do nothing;
        }

        usleep(100000);
        //Set next_produced to be a rand num
        next_produced = rand();

        //Semaphore and mutext locks
        sem_wait(&empty);
        pthread_mutex_lock(&lock);

        printf("Entered Producer!\n");

        //Put item into buffer
        buffer[in] = next_produced;
        in = (in + 1) % BUFFER_SIZE;

        //Semaphore and mutex releases
        pthread_mutex_unlock(&lock);
        sem_post(&full);

        //Print item produced
        printf("Produced %d\n", next_produced);
    }

}


void* consumer(void* arg)
{
    int next_consumed;

    while (1) {
        while (in == out) {
            //do nothing;
        }

        usleep(100000);
        sem_wait(&full);
        pthread_mutex_lock(&lock);

        printf("Entered Consumer!\n");
        
        //Remove item from buffer
        next_consumed = buffer[out];
        out = (out + 1) % BUFFER_SIZE;

        pthread_mutex_unlock(&lock);
        sem_post(&empty);

        //Print item consmed
        printf("Produced %d\n", next_consumed);
    }

}




int main(int argc, char* argv[])
{
    int err;

    //Make sure the args are correct
    if (argc != 1) {
        fprintf(stderr, "usage: a.out\n");
        return 1;
    }


    //Create mutex lock
    if (pthread_mutex_init(&lock, NULL) != 0)
    {
        printf("\n mutex init failed\n");
        return 1;
    }

    //Create semaphores
    if (sem_init(&full, 0, 0) != 0) {
        printf("\n full semaphore init failed\n");
        return 1;
    }

    if (sem_init(&empty, 0, BUFFER_SIZE)!= 0) {
        printf("\n full semaphore init failed\n");
        return 1;
    }
    


    //Thread Producer
    err = pthread_create(&(tid[0]), NULL, producer, NULL);
    if (err != 0)
        printf("\ncan't create thread :[%s]\n", strerror(err));

    //Thread Consumer
    err = pthread_create(&(tid[1]), NULL, consumer, NULL);
    if (err != 0)
        printf("\ncan't create thread :[%s]", strerror(err));
    
    //Sleep for 3 seconds
    sleep(3);

    //end program
    pthread_mutex_destroy(&lock);
    printf("Program finished!\n");
    return 0;
}

















