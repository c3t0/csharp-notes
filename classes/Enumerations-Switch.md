## Switch

If you may else statments you might benefit from switch.


## Enumerations

A data type that only allows a small set of values.

They constrain the data forcing it to comply to be one of several posibilites.

This improves code reliablity.

Is this what is used to prevent SQL injections?

### Generic Method
Enum.TryParse<Superhero>

here Superhero is a data type.

In this case we are making the generic method specific by providing a data type.

.TryParse will return true or false depending on the success of the parse attempt.

If it succeeds it will output the myValue  with the parse result

.TryParse(userValue, capitalization, out myValue)

```C#
if (Enum.TryParse<Superhero>(userValue, true, out))
            {
                switch (myValue)
                {
                    case Superhero.Batman:
                        break;
                    case Superhero.Superman:
                        break;
                    case Superhero.GreenLatern:
                        break;
                    default:
                        break;
                }
            }
Console.ReadLine();
```
