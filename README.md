# C# Zalgo
###### Forked from [marfgold1/ZalgoCSharp](https://github.com/marfgold1/ZalgoCSharp)

I forked the project and improved its code for more efficient use.

Usage:
```
string Zalgo.GenerateString(string originalStr, bool zalgoUp, bool zalgoMid, bool zalgoDown, bool ignoreZalgoChars, ushort zalgoRate);
```

Example:
```
string text = "Meow";
string zalgo = Zalgo.GenerateString(text, true, true, true, false, 5);
File.WriteAllText("meow.txt", zalgo);
```

Or using the type (ZalgoString.cs):

```
ZalgoString zalgo = "Meow";
ZalgoString intensifiedZalgo = new ZalgoString("Meow", true, true, true, false, 10);
File.WriteAllText("meow.txt", zalgo);
File.WriteAllText("meow2.txt", intensifiedZalgo);
```
