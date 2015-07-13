# Namespaces

extra unused _using_ statements will not affect the compiler

removing unused using statements will help make the meaning of the program clear.
```C#
using System;
using System.Collections.Generic; // not used in this exercise but its ok
using System.Linq;
using System.Text;
using System.Threading.Tasks;

```

Control + . (period) to select a namespace

If you need to add a .dll you can use by clicking on the solution explorer.

Right click the name of the project and then add Resources this will allow you to add a .dll that is not included in .NET.

This .dll file along with its methods and properties will be copied into the folder that will be used to compile the program. 
