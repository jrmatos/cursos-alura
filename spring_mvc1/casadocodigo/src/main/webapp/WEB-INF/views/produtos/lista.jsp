<%--
  Created by IntelliJ IDEA.
  User: paulo
  Date: 22/09/17
  Time: 22:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<html>
<head>
    <title>Casa do Codigo - Form</title>
</head>
<body>
    <h1>Lista de Produtos</h1>
    <div>${sucesso}</div>
    <table>
        <tr>
            <th>Titulo</th>
            <th>Descricao</th>
            <th>Paginas</th>
        </tr>
        <c:forEach items="${produtos}" var="produto">
            <tr>
                <td>${produto.titulo}</td>
                <td>${produto.descricao}</td>
                <td>${produto.paginas}</td>
            </tr>
        </c:forEach>
    </table>
</body>
</html>
