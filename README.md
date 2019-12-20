# C# Zalgo
###### Forked from [marfgold1/ZalgoCSharp](https://github.com/marfgold1/ZalgoCSharp)

I just improved the code for use in an entire program, and not just for Rextester.

Basically, just
```
string zalgo = ZalgoString.Generate(string originalStr, bool zalgoUp, bool zalgoMid, bool zalgoDown, bool ignoreZalgoChars, ushort zalgoRate);
```

Example:
```
string text = "Meow";
string zalgo = ZalgoString.Generate(text, true, true, true, false, 5);
File.WriteAllText("meow.txt", zalgo);
```

or using the type instead (ZalgoString.cs)

```
ZalgoString zalgo = "Meow";
ZalgoString intensifiedZalgo = new ZalgoString("Meow", true, true, true, false, 10);
File.WriteAllText("meow.txt", zalgo);
File.WriteAllText("meow2.txt", intensifiedZalgo);
```
