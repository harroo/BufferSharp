
using System;
using System.Collections.Generic;

namespace BufferSharp {

    public partial class BufferBuilder {

        private List<byte> buffer = new List<byte>();

        public BufferBuilder () { }

        public BufferBuilder (byte[] preBuffer) {

            buffer.Clear();
            AddArray(preBuffer);
        }

        public void AddArray (byte[] data) {

            foreach (byte b in data)
                buffer.Add(b);
        }

        public void Clear () { buffer.Clear(); }

        public void Reset () { index = 0; }

        public byte[] ToArray () => buffer.ToArray();

        public byte[] GetArray () => buffer.ToArray();

        public int Size => buffer.Count;
    }
}
