atualize os pacotes do note:
npm install

instale o node sass:
npm install node-sass --save

Atualize o arquivo css/style.scss e rode o node sass:
npm run sass

Para rodar o arquivo mimificado utilize o comando:
npm run sass-min

Ambos comandos estão descritos no arquivo package.json.
Caso não aconteca nada ao rodar os comandos sass ou sass-min, 
altere qualquer linha no arquivo style.scss e salve que automaticamente 
o node-sass irá gerar uma alteração para os respectivos arquivos 
style.css e style.min.css

Abra o arquivo index.html para ver o resultado