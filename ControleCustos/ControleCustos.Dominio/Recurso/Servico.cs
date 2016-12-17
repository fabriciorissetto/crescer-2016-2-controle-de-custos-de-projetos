﻿using ControleCustos.Dominio.Enum;

namespace ControleCustos.Dominio
{
    public class Servico : Recurso
    {
        public string Descricao { get; private set; }

        public TipoServico TipoServico { get; private set; }

        public Servico() { }

        public Servico(int id,
            string nome,
            TipoRecurso tipoRecurso,
            decimal valorMensal,
            SituacaoRecurso situacao,
            string descricao,
            TipoServico tipoServico)
            : base(id, nome, tipoRecurso, valorMensal, situacao)
        {
            this.Descricao = descricao;
            this.TipoServico = tipoServico;
        }
    }
}