# C# Zalgo
###### Forked from [marfgold1/ZalgoCSharp](https://github.com/marfgold1/ZalgoCSharp)

I just improved the code for use in the whole program, and not just for Rextester.

Basically, just
```
string zalgo = GenerateZalgoString(string originalStr, bool zalgoUp, bool zalgoMid, bool zalgoDown, bool ignoreZalgoChars, ushort zalgoRate);
```

Example:
```
string text = "Meow";
string zalgo = Zalgo.GenerateZalgoString(text, true, true, true, false, 5);
File.WriteAllText("meow.txt", zalgo);
```
