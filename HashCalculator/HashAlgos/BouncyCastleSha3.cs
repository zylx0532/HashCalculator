﻿using Org.BouncyCastle.Crypto.Digests;

namespace HashCalculator
{
    internal class BouncyCastleSha3 : BouncyCastleDigest
    {
        private readonly int bitLength;

        public override string AlgoName => $"SHA3-{this.bitLength}";

        public override AlgoType AlgoGroup => AlgoType.SHA3;

        public BouncyCastleSha3(int bitLength) : base(new Sha3Digest(bitLength), bitLength)
        {
            this.bitLength = bitLength;
        }

        public override IHashAlgoInfo NewInstance()
        {
            return new BouncyCastleSha3(this.bitLength);
        }
    }
}