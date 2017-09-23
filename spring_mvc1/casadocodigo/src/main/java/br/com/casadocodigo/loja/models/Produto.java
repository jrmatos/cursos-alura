package br.com.casadocodigo.loja.models;

import lombok.Data;

import javax.persistence.*;

/**
 * Created by paulo on 22/09/17.
 */
@Data
@Entity
public class Produto {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String titulo;
    private String descricao;
    private int paginas;
}
