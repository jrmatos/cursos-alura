package br.com.casadocodigo.loja.models;

import lombok.Data;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Calendar;
import java.util.List;

/**
 * Created by paulo on 22/09/17.
 */
@Data
@Entity
public class Produto {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    private String titulo;
    private String descricao;
    private Integer paginas;
    @DateTimeFormat
    private Calendar dataLancamento;
    @ElementCollection
    List<Preco> precos;
}
