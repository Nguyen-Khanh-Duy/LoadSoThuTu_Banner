namespace LoadSoThuTuPhong.Service.IS
{
    public interface IFtpService
    {
        Task<byte[]> GetFileBytesByPathAsync(string ftpFilePath);
    }
}
