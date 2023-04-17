//Sort a list of numbers using two separate threads

//by sorting half of each list separately then

//recombining the lists

#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>


int size;
int numThreads;
void* sort(void* params);    /* thread that performs basic sorting algorithm */
void* merge(void* params);    /* thread that performs merging of results */
int* items;
int* result;

typedef struct
{
    int from_index;
    int to_index;
} parameters;

int main(int argc, const char* argv[])
{
    int i;
    numThreads = numThreads;
    pthread_t tid[2];
    size = argc - 1;

    items = (int*)calloc(argc - 1, sizeof(int));
    result = (int*)calloc(argc - 1, sizeof(int));

    for (i = 1; i < argc; i++)
    {
        items[i - 1] = atoi(argv[i]);
        items[i - 1] = atoi(argv[i]);
    }

    parameters* data = (parameters*)malloc(sizeof(parameters));
    data->from_index = 0;
    data->to_index = (size / 2) - 1;
    pthread_create(&tid[0], 0, sort, data);

    data = (parameters*)malloc(sizeof(parameters));
    data->from_index = (size / 2);
    data->to_index = size - 1;
    pthread_create(&tid[1], 0, sort, data);

    for (i = 0; i < numThreads - 1; i++)
        pthread_join(tid[i], NULL);


    data = (parameters*)malloc(sizeof(parameters));
    data->from_index = 0;
    data->to_index = size - 2;
    pthread_create(&tid[2], 0, merge, data);

    pthread_join(tid[2], NULL);

    for (i = 0; i < size; i++)
    {
        printf("%d ", items[i]);
    }

    printf("\n");

    return 0;

}

void* sort(void* params)
{
    parameters* p = (parameters*)params;
    int begin = p->from_index;
    int end = p->to_index + 1;

    int i, j, temp, k;

    for (i = begin; i < end; i++)
    {
        for (j = begin; j < end - i - 1; j++)
        {
            if (items[j] > items[j + 1])
            {
                temp = items[j];
                items[j] = items[j + 1];
                items[j + 1] = temp;
            }
        }
    }

    for (i = begin; i < end; i++)
    {
        result[i] = (int)items[i];
    }

    pthread_exit(0);
}

void* merge(void* params)
{
    parameters* p = (parameters*)params;
    int begin = p->from_index;
    int end = p->to_index + 1;
    int i, j, temp;

    for (i = begin; i < end; i++)
    {
        for (j = begin; j < end - i; j++)
        {
            if (items[j] > items[j + 1])
            {
                temp = items[j];
                items[j] = items[j + 1];
                items[j + 1] = temp;
            }
        }
    }

    pthread_exit(0);
}