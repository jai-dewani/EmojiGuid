# EmojiGuid

EmojiGuid is a NuGet package that generates unique identifiers (GUIDs) using emojis instead of traditional hexadecimal characters. This provides a fun and visually distinct way to represent GUIDs in your applications.

## Features

- Generates GUID-like strings using emojis.
- Ensures uniqueness similar to standard GUIDs.
- Easy-to-use API for integration into your projects.

## Installation

Install EmojiGuid via NuGet:

```bash
dotnet add package EmojiGuid
```

## Usage

```csharp
using EmojiGuid;

var emojiGuid = EmojiGuidGenerator.NewEmojiGuid();
Console.WriteLine(emojiGuid); // Example: 🌟🎉🍕🚀🐱🌈🔥💧
```

## Use Cases

- Add a playful touch to your application.
- Use emoji-based identifiers for creative projects.
- Enhance user engagement with visually appealing IDs.

## License

This project is licensed under the MIT License.