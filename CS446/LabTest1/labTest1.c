#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>

int main() {
pid_t pid;

int main = getpid();

fork();
fork();
fork();

if(getpid() == main){
fork();
fork();
}

if( pid > 0){
//Do Nothing
}else{
printf("%d\n", getpid());
}

return 0;
}
