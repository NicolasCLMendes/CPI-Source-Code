// X509NameEntryConverter
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Utilities.Encoders;

public abstract class X509NameEntryConverter
{
	protected Asn1Object ConvertHexEncoded(string hexString, int offset)
	{
		string data = hexString.Substring(offset);
		return Asn1Object.FromByteArray(Hex.Decode(data));
	}

	protected bool CanBePrintable(string str)
	{
		return DerPrintableString.IsPrintableString(str);
	}

	public abstract Asn1Object GetConvertedValue(DerObjectIdentifier oid, string value);
}
