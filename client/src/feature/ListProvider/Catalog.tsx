import { Avatar, List, ListItem, ListItemAvatar } from "@mui/material";
import { Fragment } from "react";
import { Provider } from "../../app/models/Provider";
import ProviderList from "./ProviderList";

interface Props {
  providers : Provider[];
}

export default function ListProvider({providers} : Props){
  return (
    <Fragment>
      <ProviderList providers={providers}/>
    </Fragment>
  )
}