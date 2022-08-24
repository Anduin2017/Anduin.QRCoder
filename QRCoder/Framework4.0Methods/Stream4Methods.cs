namespace Anduin.QRCoder.Framework4._0Methods
{
    class Stream4Methods
    {
        public static void CopyTo(System.IO.Stream input, System.IO.Stream output)
        {
            var buffer = new byte[16 * 1024];
            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }
}
