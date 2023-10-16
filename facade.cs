using System.Linq.Expressions;

class VideoFile
{
    public void GetFile(){}
}

class OggCompressionCodec
{
    public void GetFile(){}
}

class MPEG4CompressionCodec
{
    public void GetFile(){}
}

class CodecFactory
{
    public void GetFile(){}
}


class VideoConverter
{
    public void Convert(string filename)
    {
        VideoFile file = new();
        CodecFactory codec = new();

        // Perform the reset ......
        // Facade: user only use this class. He doesn't need to deal with any of the aappove.
    }
}