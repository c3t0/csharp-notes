# Migrations

## First Migration

Define your model using code

### Add-Migration First 

to scafforl a migration that will create the corresponsing schema in the database

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

### Update-Database command

Once you have the scaffolded migration you can push these changes to the database using the **Update-Database** command.

