using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TremAutonomo.Models.Models
{
    public class TremModel
    {
        private const int MaxMovements = 50;
        private const int MaxConsecutiveMovements = 20;

        public int Position { get; private set; } = 0;
        public List<string> Movements { get; private set; } = new List<string>();

        public TremModel()
        {
        }

        public string GetPosicao()
        {
            return $"A atual posição do trem: {Position}.";
        }

        public string ExecutarComandos(List<string> commands)
        {
            int consecutiveCount = 0;
            string lastCommand = string.Empty;

            foreach (var command in commands)
            {
                if (command != "ESQUERDA" && command != "DIREITA")
                {
                    return "Erro: Comando inválido detectado.";
                }

                if (command == lastCommand)
                {
                    consecutiveCount++;
                }
                else
                {
                    consecutiveCount = 1;
                    lastCommand = command;
                }

                if (consecutiveCount > MaxConsecutiveMovements)
                {
                    return "Erro: Mais de 20 movimentos consecutivos na mesma direção.";
                }

                if (Movements.Count >= MaxMovements)
                {
                    break;
                }

                Movements.Add(command);
                Position += command == "DIREITA" ? 1 : -1;
            }

            return $"Movimentos executados com sucesso. Posição final do trem: {Position}.";
        }
    }
}
