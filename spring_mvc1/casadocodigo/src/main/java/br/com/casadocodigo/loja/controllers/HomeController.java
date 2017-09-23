package br.com.casadocodigo.loja.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 * Created by paulo on 22/09/17.
 */
@Controller
public class HomeController {

    @RequestMapping("/")
    public String index() {
        System.out.println("Entrando na Home da Casa do Codigo");
        return "home";
    }

}
