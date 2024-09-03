using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TremAutonomo.Models.Models;

namespace TremAutonomo.Test
{
    public class TrainTests
    {
        [Fact]
        public void Train_ExecutesCommands_Correctly()
        {
            var train = new TremModel();
            var commands = new List<string> { "DIREITA", "DIREITA", "ESQUERDA" };
            var result = train.ExecutarComandos(commands);

            Assert.Equal(1, train.Position);
            Assert.Equal("Movimentos executados com sucesso. Posição final do trem: 1.", result);
        }

        [Fact]
        public void Train_DetectsInvalidCommand()
        {
            var trem = new TremModel();
            var commands = new List<string> { "CIMA" };
            var result = trem.ExecutarComandos(commands);

            Assert.Equal("Erro: Comando inválido detectado.", result);
        }

        [Fact]
        public void Train_LimitsConsecutiveMovements()
        {
            var train = new TremModel();
            var commands = new List<string> { "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA",
                                              "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA",
                                              "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA"};
            var result = train.ExecutarComandos(commands);

            Assert.Equal("Erro: Mais de 20 movimentos consecutivos na mesma direção.", result);
        }
    }
}
