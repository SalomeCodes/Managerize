#################
# Build the app #
#################
FROM node:12-alpine as build
WORKDIR /app
COPY . ./
RUN npm install
RUN $(npm bin)/ng build --prod --configuration production --output-path=/dist

################
# Run in NGINX #
################
FROM nginx:alpine
COPY --from=build /dist /usr/share/nginx/html
COPY nginx /etc/nginx
copy nginx/letsencrypt/live/daphneprojects.nl /etc/letsencrypt/live/daphneprojects.nl

EXPOSE 80
EXPOSE 443

# When the container starts, replace the env.js with values from environment variables
CMD ["/bin/sh",  "-c",  "envsubst < /usr/share/nginx/html/assets/env.template.js > /usr/share/nginx/html/assets/env.js && exec nginx -g 'daemon off;'"]