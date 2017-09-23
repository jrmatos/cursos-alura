package br.com.casadocodigo.loja.models;

import lombok.Data;

import javax.persistence.Embeddable;
import java.math.BigDecimal;

/**
 * Created by paulo on 23/09/17.
 */
@Data
@Embeddable
public class Preco {

    private BigDecimal valor;
    private TipoPreco tipo;
}
