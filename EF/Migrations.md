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
### PM> Add-Migration First 

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

### PM> Update-Database 

Once you have the scaffolded migration you can push these changes to the database using the **Update-Database** command.

## Subsequent Migrations

### Change the Model code

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

### PM> Add-Migration Second

To scaffold the migration to a pply the corresponding changes to the database schema

Break downs steps

#### Calculate current Model

Calculate the current Model based on the modified code

Find the **previous model** embedded in the resource **~/Migrations/First.resx** file from the **last migration**

#### EdmModelDiffer

We pump **previous + current** model to **EdmModelDiffer**

Which will calculate the required database changes


#### MigrationCodeGenerator

The changes are passed to the **MigrationCodeGenerator**

Scaffold the correspongin migration into the project

**~/Migrations/Second.cs**

This also generates the ~/Migrations/Second.resx** resource file.

The model is stored as a **snapshot** in the resource file

### PM> Update-Database

Pushes the changes to the database
