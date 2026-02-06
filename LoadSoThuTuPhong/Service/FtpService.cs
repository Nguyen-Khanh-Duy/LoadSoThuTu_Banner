using FluentFTP;
using LoadSoThuTuPhong.Service.IS;

namespace LoadSoThuTuPhong.Service
{
    public class FtpService : IFtpService
    {
        private readonly string _ftpHost;
        private readonly string _ftpUsername;
        private readonly string _ftpPassword;
        private readonly ILogger<FtpService> _logger;

        public FtpService(IConfiguration configuration, ILogger<FtpService> logger) 
        {
            _ftpHost = configuration["FtpServer:ftpHost"] ?? "0.0.0.0";
            _ftpUsername = configuration["FtpServer:ftpUsername"] ?? "";
            _ftpPassword = configuration["FtpServer:ftpPassword"] ?? "";
            _logger = logger;
        }

        private FtpClient CreateFtpClient()
        {
            var client = new FtpClient(_ftpHost, _ftpUsername, _ftpPassword);
            client.Config.DataConnectionType = FtpDataConnectionType.AutoPassive;
            client.Config.EncryptionMode = FtpEncryptionMode.None;
            client.Config.ValidateAnyCertificate = true;
            client.Config.ConnectTimeout = 30000;
            client.Config.ReadTimeout = 30000;
            client.Config.DataConnectionConnectTimeout = 15000;
            client.Config.DataConnectionReadTimeout = 15000;
            client.Config.RetryAttempts = 3;
            client.Config.LogToConsole = false;

            return client;
        }

        public async Task<byte[]> GetFileBytesByPathAsync(string ftpFilePath)
        {
            try
            {
                using var ftpClient = CreateFtpClient();
                ftpClient.Connect();

                try
                {
                    using var ms = new MemoryStream();
                    ftpClient.DownloadStream(ms, ftpFilePath);
                    ftpClient.Disconnect();
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    ftpClient.Disconnect();
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
