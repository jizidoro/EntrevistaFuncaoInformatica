using EntrevistaFuncaoInformatica.Application.Messages;
using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;
using FluentValidation;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class BeneficiarioClienteValidation<TDto> : DtoValidation<TDto>
		where TDto : BeneficiarioClienteDto
	{
		protected void ValidarCPF()
		{
			RuleFor(v => v.CPF)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(15).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("CPF");
		}

		protected void ValidarNome()
		{
			RuleFor(v => v.Nome)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(127).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Nome");
		}

	}
}
