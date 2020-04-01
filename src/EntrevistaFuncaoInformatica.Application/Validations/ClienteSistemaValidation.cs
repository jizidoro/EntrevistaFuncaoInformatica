using EntrevistaFuncaoInformatica.Application.Messages;
using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;
using FluentValidation;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class ClienteSistemaValidation<TDto> : DtoValidation<TDto>
		where TDto : ClienteSistemaDto
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

		protected void ValidarSobrenome()
		{
			RuleFor(v => v.Sobrenome)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(127).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Sobrenome");
		}

		protected void ValidarNacionalidade()
		{
			RuleFor(v => v.Nacionalidade)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(63).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Nacionalidade");
		}

		protected void ValidarCep()
		{
			RuleFor(v => v.Cep)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(15).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Cep");
		}

		protected void ValidarEstado()
		{
			RuleFor(v => v.Estado)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(63).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Estado");
		}

		protected void ValidarCidade()
		{
			RuleFor(v => v.Cidade)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(63).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Cidade");
		}

		protected void ValidarLogradouro()
		{
			RuleFor(v => v.Logradouro)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(31).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Logradouro");
		}

		protected void ValidarEmail()
		{
			RuleFor(v => v.Email)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(255).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Email");
		}

		protected void ValidarTelefone()
		{
			RuleFor(v => v.Telefone)
				.NotEmpty().WithMessage(MensagensAplicacao.CAMPO_OBRIGATORIO)
				.MaximumLength(31).WithMessage(MensagensAplicacao.TAMANHO_ESPECIFICO_CAMPO)
				.WithName("Telefone");
		}


	}
}
