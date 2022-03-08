"# singleton-anatomy-c-" 

#Local variables
In case of singleton pattern local variable declared in methods are allocated freshly on the stack for each caller, regardless of the threading situation and are thus inherently thread-safe.

#shared variables

They are allocated once and can have concurency issue
