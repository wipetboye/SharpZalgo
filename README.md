# C# Zalgo
###### Forked from marfgold1/ZalgoCSharp

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
