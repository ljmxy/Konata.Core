﻿using Konata.Msf.Utils.Crypt;

namespace Konata.Msf.Packets.Tlv
{
    public class T202Body : TlvBody
    {
        public readonly byte[] _wifiBssidMd5;
        public readonly string _wifiSsid;

        public T202Body(byte[] wifiBssid, string wifiSsid)
            : base()
        {
            _wifiSsid = wifiSsid;
            _wifiBssidMd5 = new Md5Cryptor().Encrypt(wifiBssid);

            PutBytes(_wifiBssidMd5, 2, 16);
            PutString(_wifiSsid, 2, 32);
        }

        public T202Body(byte[] data)
            : base(data)
        {
            TakeBytes(out _wifiBssidMd5, Prefix.Uint16);
            TakeString(out _wifiSsid, Prefix.Uint16);
        }
    }
}