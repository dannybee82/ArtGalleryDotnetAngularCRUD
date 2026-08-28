# Fetch node.js version 22 the alpine (small) version.
FROM node:22-alpine As builder

WORKDIR /usr/src/app

COPY package*.json ./

RUN npm install -g @angular/cli@22.1.6

RUN npm install

COPY . .

RUN ng build --configuration production

#install nginx
FROM nginx:stable-alpine

COPY nginx.conf.prod /etc/nginx/conf.d/default.conf
COPY --from=builder /usr/src/app/dist/* /usr/share/nginx/html

EXPOSE 80