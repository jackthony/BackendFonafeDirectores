using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Domain.EMP_Cargo.Models;
using Shared.Kernel.Interfaces;
using Shared.Time;

namespace Empresa.Application.EMP_Cargo.Mappers
{
    public class CrearCargoMapper : IMapper<CrearCargoRequest, CrearCargoData>
    {
        private readonly ITimeProvider _timeProvider;
        public CrearCargoMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public CrearCargoData Map(CrearCargoRequest request)
        {
            return new CrearCargoData
            {
                UsuarioRegistroId = request.UsuarioRegistroId,
                NombreCargo = request.NombreCargo,
                IsActivo = true,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
/*
[Fact]
public void Map_DeberiaMapearCorrectamente()
{
    // Arrange
    var fixedNow = new DateTime(2025, 6, 20, 10, 0, 0);
    var mockTime = new Mock<ITimeProvider>();
    mockTime.Setup(tp => tp.NowPeru).Returns(fixedNow);

    var mapper = new CrearCargoMapper(mockTime.Object);
    var request = new CrearCargoRequest
    {
        UsuarioRegistroId = 1,
        NombreCargo = "Administrador"
    };

    // Act
    var data = mapper.Map(request);

    // Assert
    Assert.Equal("Administrador", data.NombreCargo);
    Assert.Equal(1, data.UsuarioRegistroId);
    Assert.Equal(true, data.IsActivo);
    Assert.Equal(fixedNow, data.FechaRegistro);
}

 */