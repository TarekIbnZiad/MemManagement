# MemManagement
Implementing the best fit and first fit memory management algorithms using C# programming language

This project was done as a part of the Operating Systems undergraduate course at Computer and Systems Engineering Department, Faculty of Engineering, ASU(Spring 2013).

The code implements the following Memory Management algorithms : 
### (1) Best Fit
### (2) First Fit 

We assume that the user would enter a sequence of processes and each one would be declared with its size. The user should also input the initial size of memory locations. The output should be the memory layout (including Full and Empty locations -Holes-). It's allowed to Allocate and Deallocate processes during execution. 

The way to represent De-allocation is that the user can add any number of processes to the memory during run time and remove what he wants. So, if a process was removed holes would be calculated again internally and be represented in the Memory Layout window in order that if another process came later and its size was suitable for that place it would take it (according to the specified Algorithm ,previously chosen by the user).
