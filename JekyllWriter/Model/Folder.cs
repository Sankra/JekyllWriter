﻿using System;
using Foundation;

namespace JekyllWriter.Model
{
    public class Folder : NSObject
    {
        public Folder(string name, SourceFile[] files)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Files = files ?? throw new ArgumentNullException(nameof(files));
        }

        public string Name { get; }
        public SourceFile[] Files { get; }
    }
}
