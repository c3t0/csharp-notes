# Migrations

## First Migration

Define your model using code

```C#
using System.Data.Entity;

namespace Blogging

public class Blogging
    {
        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }

            public class BloggingContext : DbContext
            {
                public DbSet<Blog> Blogs { get; set; }
            }
        }
    }

```
### > Add-Migration First 

to scafforld a migration that will create the corresponsing schema in the database

Calculate the model based on the code we wrote

#### Build current model

Build current model based on code 
Pass current model to the **EdmModleDiffer**

#### EdmModelDiffer

Calculates the required database changes.

Compares the current model with the previous model.

The first migration will be compared to an empty Model.

#### MigrationCodeGenerator

Reponsible for turning the changes into: 

The **scaffolded migration** that is added to your project.

It adds the C# migration code to the project
**~/Migrations/First.cs**

**resource file** contains an embedded snapshot of the model at the time of generation

**~/Migrations/First.resx**

### > Update-Database 

Once you have the scaffolded migration you can push these changes to the database using the **Update-Database** command.

## Subsequent Migrations

### Change to Model code

Make a change to the model in code

```C#
using System.Data.Entity;

namespace Blogging

public class Blogging
    {
        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }
            public string Url { get; set; } // <= new attribute

            public class BloggingContext : DbContext
            {
                public DbSet<Blog> Blogs { get; set; }
            }
        }
    }

```
