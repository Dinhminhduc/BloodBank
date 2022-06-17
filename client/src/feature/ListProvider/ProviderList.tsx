import { Grid, List, ListItem, ListItemAvatar } from "@mui/material";
import { Provider } from "../../app/models/Provider";
import ProviderCard from "./ProviderCard";

interface Props {
  providers: Provider[];
}

export default function ProviderList({providers}: Props){
  return (
    <Grid container spacing={4}>
    {providers.map(item => (
      <Grid item xs={4} key={item.id}>
        <ProviderCard provider={item} />
      </Grid>
    ))}
  </Grid>
  )
}