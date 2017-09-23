package br.com.casadocodigo.loja.daos;

import br.com.casadocodigo.loja.models.Produto;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

/**
 * Created by paulo on 22/09/17.
 */
@Repository
@Transactional
public class ProdutoDAO {

    @PersistenceContext
    EntityManager manager;

    public void gravar(Produto produto) {
        manager.persist(produto);
    }
}
