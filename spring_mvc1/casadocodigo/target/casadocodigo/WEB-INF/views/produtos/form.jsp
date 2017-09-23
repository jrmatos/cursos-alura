<%--
  Created by IntelliJ IDEA.
  User: paulo
  Date: 22/09/17
  Time: 22:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Casa do Codigo - Form</title>
</head>
<body>
    <form action="/casadocodigo/produtos" method="POST">
        <div>
            <label>Titulo</label>
            <input type="text" name="titulo"/>
        </div>
        <div>
            <label>Descricao</label>
            <textarea rows="10" cols="20" name="descricao"></textarea>
        </div>
        <div>
            <label>Paginas</label>
            <input type="number" name="paginas"/>
        </div>
        <button type="submit">Cadastrar</button>
    </form>
</body>
</html>
