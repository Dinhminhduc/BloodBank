import { Avatar, Button, Card, CardActions, CardContent, CardMedia, ListItem, ListItemAvatar, Typography } from "@mui/material";
import { Provider } from "../../app/models/Provider";

interface Props {
  provider: Provider;
}

export default function ProductCard({provider} : Props) {
  return (
    <Card>
    <CardMedia
      component="img"
      height="140"
      image="http://picsum.photos/200"
      alt="green iguana"
      title={provider.name}
    />
    <CardContent>
      <Typography gutterBottom variant="h5" color='secondary'>
        Blood Type: "{provider.bloodType}"
      </Typography>
      <Typography variant="body2" color="text.secondary">
        {provider.address} -- {provider.city} -- {provider.birth}
      </Typography>
    </CardContent>
    <CardActions>
      <Button size="small">Detail</Button>
      <Button size="small">Contact</Button>
    </CardActions>
  </Card>
  );
}
