
# BufferSharp.

Simplistic, versatile and useful class built as to manage Byte[].

```cs
// Namespace reference.
using BufferSharp;

/* Constructing. */
BufferBuilder builder = new BufferBuilder();

builder.Append("string value");
builder.Append(137); // Integer value.
builder.Append(137.0f); // Floating-Point value.

builder.AppendT(Anything); // Any object.

byte[] myData = builder.ToArray();

/* Deconstructing. */
BufferBuilder builder = new BufferBuilder(myData);

string myText = builder.GetString();
int myNumber = builder.GetInt32();
float myFloat = builder.GetSingle();

MyClass anything = (MyClass)builder.GetObject();
```

**Note.**
`BufferBuilder`s MUST be deconstructed in the exact same order that they were constructed. Else the information may become obfuscated.

The `BufferBuilder` can be used to Construct and Deconstruct `byte[]`s for any purpose you see fit, not just for use with Blitzbit.

If you wish to "Re-Read" the information from a packet, you can simply call `BufferBuilder.Reset()` and it will move the counter to the start of the buffer, therefore restarting the read out.
