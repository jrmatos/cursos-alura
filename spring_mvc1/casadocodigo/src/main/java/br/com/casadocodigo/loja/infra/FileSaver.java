package br.com.casadocodigo.loja.infra;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.springframework.web.multipart.MultipartFile;

import javax.servlet.http.HttpServletRequest;
import java.io.File;
import java.io.IOException;

/**
 * Created by paulo on 27/09/17.
 */
@Component
public class FileSaver {

    @Autowired
    public HttpServletRequest request;

    public String write(String baseFolder, MultipartFile file) {
        try {
            String realpath = request.getServletContext().getRealPath("/" + baseFolder);
            String path = realpath + File.separator + file.getOriginalFilename();
            file.transferTo(new File(path));

            return baseFolder + File.separator + file.getOriginalFilename();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

}
