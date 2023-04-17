#include <linux/init.h>
#include <linux/kernel.h>
#include <linux/module.h>
#include <linux/sched.h>


int q1_init(void)
{
  printk(KERN_INFO "Loading module...\n");

  struct task_struct *task;

  for_each_process(task)
  {
    printk(KERN_INFO "pid: %d | pname: %s\n", task->pid, task->comm);
  }

  printk(KERN_INFO "Module loaded.\n");
  return 0;
}

void q1_exit(void)
{
  printk(KERN_INFO "Module removed.\n");
}

module_init(q1_init);
module_exit(q1_exit);