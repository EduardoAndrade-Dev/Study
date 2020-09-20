import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class SpotifyService {

  constructor(private http: HttpClient) {
    console.log('Spotify service listo para usar');
  }

  getQuery(query: string) {
    const url = `https://api.spotify.com/v1/${query}`;

    const headers = new HttpHeaders({ Authorization: 'Bearer BQAnkL8pRTFsVW5lYdOqyG_9gNf_Dj63_ZxNf0HzPl6W0jWEkUvDzoa0D1pedVjWHfkWQXCNlMPPKbZaOb4' });

    return this.http.get(url, { headers });
  }

  getNewReleases() {
    return this.getQuery('browse/new-releases')
               .pipe(map(data => data['albums'].items));
  }

  getArtist(termino: string) {
    return this.getQuery(`search?q=${termino}&type=artist&limit=15`)
               .pipe(map(data => data['artists'].items));
  }

}