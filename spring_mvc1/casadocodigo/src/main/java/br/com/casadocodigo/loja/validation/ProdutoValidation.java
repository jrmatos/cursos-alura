package br.com.casadocodigo.loja.validation;

import br.com.casadocodigo.loja.models.Produto;
import org.springframework.validation.Errors;
import org.springframework.validation.ValidationUtils;
import org.springframework.validation.Validator;

/**
 * Created by paulo on 23/09/17.
 */
public class ProdutoValidation implements Validator {

    @Override
    public boolean supports(Class<?> clazz) {
        return Produto.class.isAssignableFrom(clazz);
    }

    @Override
    public void validate(Object target, Errors errors) {
        ValidationUtils.rejectIfEmpty(errors, "titulo", "field.required");
        ValidationUtils.rejectIfEmpty(errors, "descricao", "field.required");

        Produto produto = (Produto) target;
        if(produto.getPaginas() == null) {
            errors.rejectValue("paginas", "field.required");
        }
        else if(produto.getPaginas() <= 0) {
            errors.rejectValue("paginas", "field.min_length_required");
        }

    }
}
