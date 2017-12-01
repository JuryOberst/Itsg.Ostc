﻿using System.Threading.Tasks;

using Xunit;

namespace Itsg.Ostc.Test
{
    public class OstcCertsTests
    {
        [Fact]
        public async Task LoadCertsAsync()
        {
            var certs = await Certificates.ReceiverCertificates.Load();
            Assert.NotEmpty(certs.Certificates);
            Assert.NotEmpty(certs.RootCertificates);
            Assert.NotEmpty(certs.IntermediateCertificates);

            foreach (var certItem in certs.Certificates)
            {
                var chain = certs.GetCertificateChain(certItem.Value);
                Assert.Equal(8, certItem.Key.Length);
                Assert.Same(certItem.Value, chain.Certificate);
                Assert.Contains(chain.RootCertificate, certs.RootCertificates);
                Assert.All(chain.IntermediateCertificates, immedCert => Assert.Contains(immedCert, certs.IntermediateCertificates));
            }
        }
    }
}
