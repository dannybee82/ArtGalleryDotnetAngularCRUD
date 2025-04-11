import { Artist } from "../artist/artist.interface";
import { Style } from "../style/style.interface";
import { Image } from "../image/image.interface";
import { Thumbnail } from "../thumbnail/thumbnail.interface";

export interface Painting {
	id?: number,
	name: string,
	description: string,
	year: number,
	artist?: Artist,
	style?: Style,
	image?: Image,
	thumbnail?: Thumbnail
}
