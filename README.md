# Dev Setup
Must have .Net SDK 6.0.301 installed

## Build

To build the app run the following from the repository root.

```
$> dotnet build
``` 

## Tests

To run tests run the following from the repository root.

```
$> dotnet test
```

To manually test the app run the following from the repostory root.

```
$> dotnet run C --project DiamondKata/DiamondKata.csproj
```

note that in the above you can replace the command line argument 'C' with any uppercase character A through Z.

you should see the following output:

```
  A
 B B
C   C
 B B
  A
```

# Release Build

To publish a release build of the app run the following from the repository root.

```
$> dotnet publish DiamondKata/DiamondKata.csproj -p:PublishProfile=PublishTrimmed -o output -c Release
```

This does a 'Release' build of the app and puts it into the `$/output` folder.

## Run

You can then run the compiled app by running the following from the repository root.

```
$> ./output/DiamondKata.exe C
```

# The Kata
### Origin

This kata is based on a post by Seb Rose here: http://claysnow.co.uk/recycling-tests-in-tdd/

### Problem

Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe A
      A

    > diamond.exe B
       A
      B B
       A

    > diamond.exe C
        A
       B B
      C   C
       B B
        A

It may be helpful visualise the whitespace in your rendering like this:

    > diamond.exe C
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _